/*Настроить правила iptables для доступности сервисов на TCP-портах 22, 80 и 443.
Также сервер должен иметь возможность устанавливать подключения к серверу 
обновлений. Остальные подключения запретить.*/

sudo iptables -A INPUT -p tcp --dport 22 -j ACCEPT//SSH(port 22)
sudo iptables -A INPUT -p tcp --dport 80 -j ACCEPT//HTTP( port 80 )
sudo iptables -A INPUT -p tcp --dport 443 -j ACCEPT//HTTPS( port 443 ) 

//для получения Ip сервера обновлений выполним в командной строке:
// ping ru.archive.ubuntu.com
//используем полученный Ip

sudo iptables -A OUTPUT -p tcp -d 213.180.204.183 --dport 80 -j ACCEPT//сервер обновлений

sudo iptables -A INPUT -j DROP//запрет на все остальные входящие
sudo iptables-save > /etc/iptables.rules//сохранение настроек
