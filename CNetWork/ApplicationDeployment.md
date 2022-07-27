# 应用部署

* Kestrel
* Nginx
* Jexus
* IIS
* Apache
* PM2
* Supervisor
* 独立发布/单文件
* 容器（Docker/K8S/K3S/Rancher）

## 1 Kestrel

[Kestrel](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/servers/kestrel?view=aspnetcore-6.0) 是包含在 ASP.NET Core 项目模板中的 Web 服务器，默认处于启用状态。

.NET Core 支持的所有平台和版本均支持 Kestrel。

Kestrel 支持以下方案：

* HTTPS
* HTTP/2（在 macOS 上除外）
* 用于启用 WebSocket 的不透明升级
* 用于获得 Nginx 高性能的 Unix 套接字
* macOS 的未来版本将支持 HTTP/2。

.NET Core 支持的所有平台和版本均支持 Kestrel。