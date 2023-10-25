/*Подключить дополнительный репозиторий на выбор: Docker, Nginx, Oracle MySQL. Установить любой пакет из этого репозитория*/

//обновляем систему
sudo apt update
sudo apt upgrade
//устанавливаем необходимые пакеты для добавления репозитория через HTTPS
sudo apt install apt-transport-https ca-certificates curl software-properties-common
//Добавляем официальный ключ GPG Docker
curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo gpg --dearmor -o /usr/share/keyrings/docker-archive-keyring.gpg
echo "deb [arch=amd64 signed-by=/usr/share/keyrings/docker-archive-keyring.gpg] https://download.docker.com/linux/ubuntu $(lsb_release -cs) stable" | sudo tee /etc/apt/sources.list.d/docker.list
//обновляем список пакетов
sudo apt update
//Устанавливаем Docker
sudo apt install docker-ce
//запускаем службу и добавляем её в автозагрузку
sudo systemctl start docker
sudo systemctl enable docker
// добаляем образ Ubuntu из Docker Hub.
sudo docker pull ubuntu
