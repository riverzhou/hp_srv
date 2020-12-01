#!/usr/bin/env python3

from mysql.connector    import connect
from redis              import StrictRedis

from pp_log             import posix_logger
from pp_config          import pp_config

#=============================================

#=============================================

class mysql_db():
        global  pp_config
        ip      = pp_config['mysql_ip']
        port    = pp_config['mysql_port']
        user    = pp_config['mysql_user']
        passwd  = pp_config['mysql_pass']
        db      = pp_config['mysql_db']
        table   = pp_config['mysql_table']

        add_udp_record = (('INSERT INTO %s ' % table) +
               '(daytime, info) ' +
               'VALUES (%s, %s)')

        def connect_mysql(self):
                try:
                        return connect(host = self.ip, port = self.port, user = self.user, password = self.passwd, database = self.db)
                except:
                        return None

        def __init__(self):
                self.mysql    = self.connect_mysql()
                if self.mysql == None : return None
                self.cursor = self.mysql.cursor()

        def put(self, buff):
                self.cursor.execute(self.add_udp_record, buff)

        def flush(self):
                self.mysql.commit()
                self.cursor.close()
                self.mysql.close()

class redis_db():
        global  pp_config
        ip      = pp_config['redis_ip']
        port    = pp_config['redis_port']
        passwd  = pp_config['redis_pass']
        db      = pp_config['redis_db']

        def connect_redis(self):
                try:
                        return StrictRedis(host = self.ip, port = self.port, password = self.passwd, db = self.db)
                except:
                        return None

        def __init__(self):
                self.redis    = self.connect_redis()
                if self.redis == None : return None

        def get(self, key):
                return self.redis.get(key)

        def set(self, key, val):
                return self.redis.set(key, val)

        def delete(self, key):
                return self.redis.delete(key)



