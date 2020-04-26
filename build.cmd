docker build -t kkbruce/redis:master-4.0.14.2-aof-nanoserver-1909 --network "Default Switch" -f .\Dockerfile-Master .
docker build -t kkbruce/redis:slave-4.0.14.2-aof-nanoserver-1909 --network "Default Switch" -f .\Dockerfile-Slave .
docker build -t kkbruce/redis:sentinel-4.0.14.2-aof-nanoserver-1909 --network "Default Switch" -f .\Dockerfile-Sentinel .