# Unity UDP Client

A Multiplayer setup for unity that is capable of sending and receiving responses that include player transforms and other messages

## Important note: Currently in development phase

## What is the use of this Repo

This Project is a Simple Unity Project which demonstrates the following
1. How to create dgrams client for unity
2. How to connect to local/staging server and communicate with the server
3. A template for future games that are mostly multiplayer.

The project Template can be used to build other games.

## Prerequisites

### Server

#### Install Node JS
Refer to https://nodejs.org/en/ to install nodejs

#### Install dgram package
Install the dgram official library for node

```bash
npm i dgram
```

#### Pre built server
Find the pre built server for this at [udp_backend](https://github.com/Mark-42-max/Unity_UDP_Server)

### Client

#### Install Unity
Refer to https://unity.com/download for downloading unity and unity hub (optional but recommended)

#### License
Licensing would be done on unity hub. Highly recommended to be done before moving on.

## Clone the project

### After cloning the client is going to use port 5600 for sending and receiving data. Be sure to clear the specific port before running.
