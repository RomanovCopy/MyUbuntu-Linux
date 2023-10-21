/*создать группу с использованием утилит groupadd и addgroup;
попрактиковаться в смене групп у пользователей;
добавить пользователя в группу, не меняя основной;
• Создать пользователя с правами суперпользователя. 
Сделать так, чтобы sudo не требовал пароль для выполнения команд*/

sudo groupadd newGroup
sudo addgroup newGroup2

sudo usermod -aG newGroup user
sudo usermod -aG newGroup2 user2

sudo adduser superuser
sudo usermod -aG sudo superuser

//Изменим файл /etc/sudoers с помощью visudo:
sudo visudo
//добавив строчку
user ALL=(ALL:ALL) NOPASSWD:ALL


