Установка Docker

sudo apt update
sudo apt install docker.io

Установка  Docker Compose

sudo curl -L "https://github.com/docker/compose/releases/latest/download/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose
sudo chmod +x /usr/local/bin/docker-compose

Создаем файл конфигурации для docker-compose(приведен отдельным файлом)

nano /etc/docker/docker-compose.yml

Файлы конфигурации для Nginx Apache будут созданы автоматически и изменять их, в данном случае, нет необходимости.

На хостовой машине
/etc/nginx/nginx.conf
/usr/local/apache2/conf/httpd.conf

Для просмотра файлов внутри контейнеров

Nginx

docker-compose exec nginx cat /etc/nginx/nginx.conf

Apache

docker-compose exec apache cat /usr/local/apache2/conf/httpd.conf



Запускаем контейнеры

docker-compose up -d

Для проверки работоспособности переходим по адресу 213.171.12.142:8080( скриншот прилагается )

Просматриваем логи ( прилагаются )

docker-compose logs nginx
docker-compose logs apache
docker-compose logs php-fpm
