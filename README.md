# RedisSentinelHA

Redis Master-Slave-Sentinel HA Arch for Windows Container

More detail see blog article: https://blog.kkbruce.net/2020/02/redis-master-slave-sentinel-for-windows.html

## Run & Test

一、Create a redis-net

```dos
docker network create -d nat --subnet=10.10.10.0/24 --gateway 10.10.10.1 --ipam-driver windows --opt com.docker.network.windowsshim.networkname=redis-net redis-net
```

二、Run docker-compose

```dos
docker-compose.exe up -d
```

三、Run RedisApiSrc test project

```dos
dotnet run
```