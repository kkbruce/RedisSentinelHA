docker build -t kkbruce/redis:master-5.0.9-aof-nanoserver-1909 --network "Default Switch" -f .\Dockerfile-Master .
docker build -t kkbruce/redis:slave-5.0.9-aof-nanoserver-1909 --network "Default Switch" -f .\Dockerfile-Slave .
docker build -t kkbruce/redis:sentinel-5.0.9-aof-nanoserver-1909 --network "Default Switch" -f .\Dockerfile-Sentinel .

docker push kkbruce/redis:master-5.0.9-aof-nanoserver-1909
docker push kkbruce/redis:slave-5.0.9-aof-nanoserver-1909
docker push kkbruce/redis:sentinel-5.0.9-aof-nanoserver-1909