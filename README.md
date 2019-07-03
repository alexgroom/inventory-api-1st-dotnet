# Coolstore.Inventory - ASP.NET Core 2.0 Server

Inventory API for the Cloud Native Workshop

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/Coolstore.Inventory
docker build -t coolstore.inventory .
docker run -p 5000:5000 coolstore.inventory
```
