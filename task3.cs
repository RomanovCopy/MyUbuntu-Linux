/* Запретить любой входящий трафик с IP 3.4.5.6.*/
sudo iptables -A INPUT -s 3.4.5.6 -j DROP
sudo iptables-save > /etc/iptables.rules