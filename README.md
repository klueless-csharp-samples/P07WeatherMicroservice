# P07weathermicroservice

> P07 Weather Microservice is a simple webapi app with responsive page

## Source: Creating a .NET 5 Microservice

[YouTube](https://www.youtube.com/watch?v=MIJJCR3ndQQ&t=2164s)

## Development

### Build watchers

Build and run command line application of file change

```bash
dotnet watch run
```

Build with automatic unit test execution

```bash
dotnet watch test
```

## Stories

### Main Story

As a C# Developer, I want a simple WebApi to lookup Weather service, so that I practice web apps

See all [stories](./STORIES.md)

## Usage

See all [usage examples](./USAGE.md)

### Basic Example

#### Basic example

Description for a basic example to be featured in the main README.MD file

```ruby
class SomeRuby; end
```

### My Local Development Setup

#### Global Tools

Note, you only need to load these once

```bash
# Tooling for entity framework 4
dotnet tool install --global dotnet-ef

# dotnet-format is a code formatter for dotnet that applies style preferences to a project or solution
dotnet tool install -g dotnet-format

```

#### Docker compose for MsSQL 2019 and Postres 13

```bash
cd ~/dev/docker
# Run locally (if you need to test, otherwise)
docker compose up
# Run detached
docker compose up -d

# logs from docker folder
docker-compose logs -f pg13
docker-compose logs -f mssql2019
```

#### Need to check logs from other development folder?

```
docker logs -f pg13
docker logs -f mssql2019
```

#### Connect to Postgres

```bash
docker-compose exec -u postgres pg13 bash

psql
# List of databases
\l
```

#### Connect to MsSQL

```bash
docker exec -it mssql2019 "bash"

/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P '[Password]'

SELECT Name from sys.Databases
GO
```

#### need to check environment?

```
docker exec -it pg13 env
```

### Add/update migrations

```bash
dotnet ef migrations add Initial
dotnet ef migrations add Initial --context P02PgContext

dotnet ef database update
dotnet ef database update --context P02PgContext

dotnet ef migrations add UpdatePerson
dotnet ef database update
```

## Contributing

Bug reports and pull requests are welcome on GitHub at https://github.com/klueless-io/P07WeatherMicroservice. This project is intended to be a safe, welcoming space for collaboration, and contributors are expected to adhere to the [Contributor Covenant](http://contributor-covenant.org) code of conduct.

## License

The gem is available as open source under the terms of the [MIT License](https://opensource.org/licenses/MIT).

## Code of Conduct

Everyone interacting in the P07weathermicroservice project’s codebases, issue trackers, chat rooms and mailing lists is expected to follow the [code of conduct](https://github.com/klueless-io/P07WeatherMicroservice/blob/master/CODE_OF_CONDUCT.md).

## Copyright

Copyright (c) David Cruwys. See [MIT License](LICENSE.txt) for further details.
