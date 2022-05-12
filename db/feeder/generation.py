import random
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
    __slots__ = ('firstname', 'lastname', 'email', 'authentication_string', 'phone', 'salt', 'created_date', 'user_type')

    def __init__(self):
        self.firstname = fake.first_name()
        self.lastname = fake.last_name()
        self.phone = fake.phone_number()
        self.email = fake.email()

        password = fake.password()
        print(self.email, '->', password)

        self.salt = secrets.token_hex(16)
        self.authentication_string = sha256((password + self.salt).encode('utf-8')).hexdigest()
        self.user_type = next(self._gen_role_id)

        self.created_date = fake.date_time_between(start_date='-1y', end_date='now', tzinfo=None)


@meta.generate(3)
class AccountType(Feed):

    @staticmethod
    def _gen_fields():
        yield from (
            ('courant', 1, 999_999),
            ('livret A', 1.004, 25_000),
            ('livret Jeune', 1.008, 2_700)
        )

    _gen_fields = _gen_fields()
    __slots__ = ('name', 'interest', 'ceil')

    def __init__(self):
        self.name, self.interest, self.ceil = next(self._gen_fields())


@meta.generate(30)
class BankAccount(Feed):

    @staticmethod
    def _gen_foreign():
        i = 1
        while True:
            yield i, 1
            yield i, 2
            yield i, 3
            i += 1

    _gen_user_id = _gen_foreign()
    __slots__ = ('user_id', 'account_type', 'balance', 'iban', 'created_date')

    def __init__(self):
        self.user_id, self.account_type = next(self._gen_foreign())

        if self.account_type == 1:
            self.balance = random.randint(0, 50000)

            if not random.randint(0, 1) and self.balance < 1000:
                self.balance = -self.balance

        elif self.account_type == 2:
            self.balance = random.randint(0, 2000)

        elif self.account_type == 3:
            self.balance = random.randint(200, 1500)

        self.iban = fake.iban()
        self.created_date = fake.date_time_between(start_date='-1y', end_date='now', tzinfo=None)


@meta.generate(5)
class CryptoCurrency(Feed):

    @staticmethod
    def _gen_name():
        yield 'Bitcoin'
        yield 'Monero'
        yield ''

    _gen_name = _gen_name()
    __slots__ = ('name',)

    def __init__(self):
        self.name = next(self._gen_name)
