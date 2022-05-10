import secrets
from hashlib import sha256

from db.feeder.meta import meta, Feed, fake


@meta.generate(2)
class UserType(Feed):

    @staticmethod
    def gen_role():
        yield 'admin'
        yield 'user'

    _gen_role = gen_role()
    __slots__ = ('name',)

    def __init__(self):
        self.name = next(self._gen_role)


@meta.generate(10)
class User(Feed):

    @staticmethod
    def gen_role_id():
        yield 1
        while True:
            yield 2

    _gen_role_id = gen_role_id()
    __slots__ = ('firstname', 'lastname', 'phone', 'email', 'authentication_string', 'salt')

    def __init__(self):
        self.firstname = fake.first_name()
        self.lastname = fake.last_name()
        self.phone = fake.phone_number()
        self.email = fake.email()

        password = fake.password()
        print(self.email, '->', password)

        self.salt = secrets.token_hex(16)
        self.authentication_string = sha256((password + self.salt).encode('utf-8')).hexdigest()
        self.role = next(self._gen_role_id)
