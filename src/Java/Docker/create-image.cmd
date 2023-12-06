docker build --no-cache -f SQL\Dockerfile.PostgreSql -t proba-java/postgre-sql ../../SQL

docker build --no-cache -f Dockerfile -t proba-java/app ../../..
