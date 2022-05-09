import asyncio

import faker
from dotenv import dotenv_values

from db_wrapper import DBWrapper
from db.feeder.generation import meta


async def feed_db(db):
    for table, rows in meta.data.items():
        header, rows = rows[0], rows[1:]

        sql = f"INSERT INTO user ({', '.join(header)}) VALUES ({', '.join('%s' for _ in header)})"

        async with db.query() as cur:
            for row in rows:
                await cur.execute(sql, row)



async def main():
    dotenv = dict(dotenv_values())

    db = await DBWrapper(
        user=dotenv.get('DB_USER'),
        db=dotenv.get('DB_NAME'),
        password=dotenv.get('DB_PASSWORD'),
        host=dotenv.get('DB_HOST', 'localhost'),
        port=int(dotenv.get('DB_PORT', 3306))
    ).connect()

    await feed_db(db)


if __name__ == '__main__':
    loop = asyncio.new_event_loop()
    loop.run_until_complete(main())
