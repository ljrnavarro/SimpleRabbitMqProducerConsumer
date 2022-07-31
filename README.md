# SimpleRabbitMqProducerConsumer
Simple Example that Producer and Consumer - .Net and RabbitMq

# This project is build in .Net Core version 5. and connect in RabbitMq server. 

## You need Visual Studio or Visual Studio Code for run and test this project.

This project is based in RabbitMq oficial page. <a href="https://www.rabbitmq.com/tutorials/tutorial-one-dotnet.html" target="_blank">RabbitMq Oficial Page</a> !

## For execute this project, please follow the step by stap.

1. Install the RabbitMq server or Load in Docker: 
docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.10-management

2. Execute the RbProducer Project for insert messages in server.

3. Execute this RbConsumer for read the server mensages.
