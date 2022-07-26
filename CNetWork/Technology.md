# 百度云盘资源迁移到阿里云盘

https://blog.csdn.net/sinat_35073873/article/details/122419796

1. 苦于百度网盘下载速度慢良久，听说阿里云盘不限速。就想要从百度云盘将资源迁移到阿里云盘。不动脑子就能想到的方法就是，先将百度云盘的资源下载到本地电脑，再将资源从本地上传到阿里云盘。这样就做到了资源的迁移。

2. 问题是这样手动的操作费时费力，文件多的话是个很大的成本。

3. 现阶段比较好的方法，将阿里云盘当成本地磁盘一样。资源从百度云盘直接下载到阿里云盘。不用手动的操作，这样是一个比较完美高效的方式。

4. 百度网盘下载限速，可以开通一个时长包会员或者开通一个月的会员。这样应该很快就能够迁移完成。

5. 整个操作分两步。

6. 第一步，挂载阿里云盘。第二步，百度云盘下载目的目录选择阿里云盘。

## 第一步 挂载阿里云盘

1. 运行webdav-aliyundriver（下载地址），有Java运行环境的朋友直接采用jar包的方式启动，没有的话就用docker容器运行。官方地址：https://github.com/zxbu/webdav-aliyundriver

2. 这里需要refresh-token，为网页版阿里云盘的token，浏览器登录阿里云盘后可获得。以Chrome浏览器为例：F12->Application->Storage->Local Storage->token->refresh_token，将这串32位值保存下来。

3. 运行jar运行方式: java -jar webdav-aliyundriver.jar --aliyundrive.refresh-token=“your refreshToken”

4. 利用raidrive（下载地址）官方地址：https://www.raidrive.com/download。将阿里云盘作为本机磁盘挂载上。挂载时按照图示步骤操作，挂载成功后能看到我的电脑磁盘多了一个盘，至此就可以把阿里云盘当做本地磁盘一样操作了。

# 第二步 百度云盘迁移

1. 登录百度云盘，选择要下载的资源，点击下载。选择下载目录，选择阿里云盘。开始下载。


