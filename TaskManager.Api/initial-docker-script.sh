1) docker build -t profjordanov/taskmanager .

2) docker run -d -p 8080:5000 -v "%cd%":/app profjordanov/taskmanager