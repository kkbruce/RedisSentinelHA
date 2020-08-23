docker build -t kkbruce/redis:master-4.0.14.2-aof-nanoserver-2004 --network "Default Switch" -f .\Dockerfile-Master .
docker build -t kkbruce/redis:slave-4.0.14.2-aof-nanoserver-2004 --network "Default Switch" -f .\Dockerfile-Slave .
docker build -t kkbruce/redis:sentinel-4.0.14.2-aof-nanoserver-2004 --network "Default Switch" -f .\Dockerfile-Sentinel .

docker push kkbruce/redis:master-4.0.14.2-aof-nanoserver-2004
docker push kkbruce/redis:slave-4.0.14.2-aof-nanoserver-2004
docker push kkbruce/redis:sentinel-4.0.14.2-aof-nanoserver-2004

REM docker build -t kkbruce/redis:master-5.0.9-aof-nanoserver-2004 --network "Default Switch" -f .\Dockerfile-Master .
REM docker build -t kkbruce/redis:slave-5.0.9-aof-nanoserver-2004 --network "Default Switch" -f .\Dockerfile-Slave .
REM docker build -t kkbruce/redis:sentinel-5.0.9-aof-nanoserver-2004 --network "Default Switch" -f .\Dockerfile-Sentinel .

REM docker push kkbruce/redis:master-5.0.9-aof-nanoserver-2004
REM docker push kkbruce/redis:slave-5.0.9-aof-nanoserver-2004
REM docker push kkbruce/redis:sentinel-5.0.9-aof-nanoserver-2004