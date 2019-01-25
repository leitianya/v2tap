#!/usr/bin/env python3
# -*- coding: utf-8 -*-
import hashlib

def md5sum(filename):
    hash_md5 = hashlib.md5()
    with open(filename, 'rb') as f:
        for chunk in iter(lambda: f.read(4096), b''):
            hash_md5.update(chunk)
    return hash_md5.hexdigest()

def sha1sum(filename):
    hash_sha1 = hashlib.sha1()
    with open(filename, 'rb') as f:
        for chunk in iter(lambda: f.read(4096), b''):
            hash_sha1.update(chunk)
    return hash_sha1.hexdigest()

def sha256sum(filename):
    hash_sha256 = hashlib.sha256()
    with open(filename, 'rb') as f:
        for chunk in iter(lambda: f.read(4096), b''):
            hash_sha256.update(chunk)
    return hash_sha256.hexdigest()

print('v2tap 版本：1.1.3-STABLE')
print('v2ray-core 版本：4.13.0')
print('')
print('此包中附带 TUN/TAP 驱动程序！')
print('')
print('警告：32 位版本没有经过测试（手上没有 32 位系统的机器）')
print('')
print('| 文件名 | md5sum | sha1sum | sha256sum |')
print('| :-- | :-- | :-- | :-- |')

v2tap_x64_md5 = md5sum('v2tap\\bin\\Release_x64\\v2tap_x64\\v2tap_x64.7z')
v2tap_x64_sha1 = sha1sum('v2tap\\bin\\Release_x64\\v2tap_x64\\v2tap_x64.7z')
v2tap_x64_sha256 = sha256sum('v2tap\\bin\\Release_x64\\v2tap_x64\\v2tap_x64.7z')
print('| v2tap_x64.7z | ' + v2tap_x64_md5 + ' | ' + v2tap_x64_sha1 + ' | ' + v2tap_x64_sha256 + ' |')

v2tap_x86_md5 = md5sum('v2tap\\bin\\Release_x86\\v2tap_x86\\v2tap_x86.7z')
v2tap_x86_sha1 = sha1sum('v2tap\\bin\\Release_x86\\v2tap_x86\\v2tap_x86.7z')
v2tap_x86_sha256 = sha256sum('v2tap\\bin\\Release_x86\\v2tap_x86\\v2tap_x86.7z')
print('| v2tap_x86.7z | ' + v2tap_x86_md5 + ' | ' + v2tap_x86_sha1 + ' | ' + v2tap_x86_sha256 + ' |')