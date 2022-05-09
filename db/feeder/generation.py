import secrets
from hashlib import sha256

from db.feeder.meta import meta, Feed, fake


@meta.generate(10)
class User(Feed):
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

        def gen_role():
            yield 1
            while True:
                yield 2

        self.role = gen_role()
