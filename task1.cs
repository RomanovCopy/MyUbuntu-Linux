/* Настроить статическую конфигурацию (без DHCP) в Ubuntu через ip и netplan.
Настроить IP, маршрут по умолчанию и DNS-сервера (1.1.1.1 и 8.8.8.8).
Проверить работоспособность сети.*/

sudo su //получаем права root
cat > /etc/netplan/mystatic01.yaml //создаем и сохраняем файл конфигурации
network:
  version: 2
  renderer: networkd
  ethernets:
    enp0s3:
      addresses:
        - 10.0.2.15/24
      gateway4: 10.0.2.2
      nameservers:
        addresses:
          - 1.1.1.1 
          - 8.8.8.8

exit//выходим из root
sudo netplan try//проверяем конфигурацию
sudo netplan apply//применяем конфигурацию

//проверяем успешность применения новой статической конфигурации
ip a
ip r

