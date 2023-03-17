<h1 align="center"> Team Service </h1> <br>

<p align="center">
  This microservice is responsible for storing all the information about teams and players that are known in our platform. Along with that, it also manages all the acronyms that different bookmakers use to identify a team or player.
</p>

## Table of Contents

- [Domain](#introduction)
- [Features](#features)
- [Requirements](#requirements)
- [Quick Start](#quick-start)

## Domain

![Domain](https://github.com/skullizador/team-service/blob/main/resources/domain.png)

## Features

* Create team :heavy_check_mark:
* Update team :heavy_check_mark:
* Delete team :heavy_check_mark:
* Get all teams :heavy_check_mark:
* Get team information :heavy_check_mark:
* Create team acronym :heavy_check_mark:
* Delete team acronym :heavy_check_mark:
* Get acronyms in a team :heavy_check_mark:

## Requirements
The application can be run locally or in a docker container, the requirements for each setup are listed below.

### Docker
* [Docker](https://www.docker.com/get-docker)

## Quick Start 
### Run Docker

First build the image:
```bash
$ docker build . -t team-service:{version}
```

When ready, run it:
```bash
$ docker run -p {port:port} team-service:{version}
```

Application will run by default on port `5000`