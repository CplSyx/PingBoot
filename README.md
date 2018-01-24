# PingBoot

This application will ping three locations at a set interval. If there are 3 consecutive failures to reach any endpoint, the application will then restart the host machine. 

The idea is to restart any network connections if there are issue with wifi adapters etc.

Endpoint locations can be IP addresses or websites - it is recommended to try both an internal location and an external one to prevent  restarts for an external network failure.
