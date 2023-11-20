version: '3'
services:
  nginx:
    image: nginx:latest
    ports:
      - "80:80"
    volumes:
      - ./nginx:/etc/nginx
  apache:
    image: httpd:latest
    ports:
      - "8080:80"
    volumes:
      - ./apache:/etc/apache
      - ./php:/var/www/html
    depends_on:
      - php-fpm
  php-fpm:
    image: php:8.1-fpm
    volumes:
      - ./php:/var/www/html
  db:
    image: mysql:latest
    environment:
      MYSQL_ROOT_PASSWORD: "${MYSQL_ROOT_PASSWORD:-12345}"
      MYSQL_DATABASE: "${MYSQL_DATABASE:-my_example_db}"
      MYSQL_USER: "${MYSQL_USER:-root}"
      MYSQL_PASSWORD: "${MYSQL_PASSWORD:-12345}"
    volumes:
      - db_data:/var/lib/mysql
volumes:
  db_data: