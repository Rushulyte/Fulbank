import asyncio
from contextlib import asynccontextmanager
from dataclasses import dataclass

import aiomysql


@dataclass
class DBWrapper:
    user: str
    db:  str
    password: str
    host: str = "localhost"
    port: int = 3306
    __pool = None

    async def connect(self):
        self.__pool = await aiomysql.create_pool(
            host=self.host, port=self.port,
            user=self.user, password=self.password,
            db=self.db, loop=asyncio.get_event_loop()
        )
        return self

    @asynccontextmanager
    async def query(self):
        async with self.__pool.acquire() as conn:
            async with conn.cursor() as cur:
                yield cur
                await cur.close()
            await conn.commit()
            conn.close()

    async def close(self):
        self.__pool.close()
        await self.__pool.wait_closed()
