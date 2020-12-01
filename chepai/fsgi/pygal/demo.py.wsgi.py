#!/usr/bin/env python3

from wsgiref.simple_server import make_server 

from pygal      import Line

from pp_log     import posix_logger
from pp_db      import mysql_db, redis_db

#=======================================

logger = posix_logger('pygal.log')
mysql  = mysql_db()
redis  = redis_db()

if mysql != None : logger.info('mysql connect init ok')
if redis != None : logger.info('redis connect init ok')

#=======================================

def application(env, start_response):
        global logger, mysql, redis
        req = env['REQUEST_URI'].split('/',2)[2].strip().strip('?')
        logger.debug(req)
        data = redis.get(req)
        if data == None : data = (req + ':Data no found !!!').encode()
        start_response('200 OK', [('Content-Type','text/html')])
        return [data]

httpd = make_server('', 9000, application)  
httpd.serve_forever()  
