import faker


class Feed:

    def __repr__(self):
        return f'{self.__class__.__name__}(%s)' % ', '.join(
            f'{k}={self.__getattribute__(k)}' for k in self.__slots__
        )

    def to_tuple(self):
        return tuple(str(self.__getattribute__(k)) for k in self.__slots__)


class Meta:
    data = {}

    @classmethod
    def generate(cls, iterations):
        def wrapped(obj):
            cls.data[obj.__name__] = [obj.__slots__]
            for i in range(iterations):
                cls.data[obj.__name__].append(obj().to_tuple())
            return obj
        return wrapped


fake = faker.Faker().unique
meta = Meta()
