#!/usr/bin/env python3

import  logging

#===========================================================================================================

class posix_logger():
        def __init__(self, name , log =  None, level = 'debug' , fmt = True ):
                LEVELS = {
                        'debug'   : logging.DEBUG,
                        'info'    : logging.INFO,
                        'warning' : logging.WARNING,
                        'error'   : logging.ERROR,
                        'critical': logging.CRITICAL
                        }
                level = LEVELS[level] if level in LEVELS else 'debug'
                # 创建一个logger
                logger = logging.getLogger(log) if log != None else logging.getLogger()
                logger.setLevel(logging.DEBUG)
                # 定义handler的输出格式
                NORMAL_FORMAT     = '%(asctime)s - %(levelname)-8s ->|%(message)s'
                normal_formatter  = logging.Formatter(NORMAL_FORMAT)
                none_formatter    = logging.Formatter()
                file_formatter    = normal_formatter  if fmt == True   else none_formatter
                # 创建一个handler，用于写入日志文件，再添加到logger
                if name != None :
                        fh = logging.FileHandler(name)
                        fh.setLevel(level)
                        fh.setFormatter(file_formatter)
                        logger.addHandler(fh)
                self.logger = logger

        def debug(self,message):
                self.logger.debug(message)

        def info(self,message):
                self.logger.info(message)

        def warning(self,message):
                self.logger.warn(message)

        def error(self,message):
                self.logger.error(message)

        def critical(self,message):
                self.logger.critical(message)



