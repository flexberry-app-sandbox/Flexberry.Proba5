docker build --no-cache -f SQL\Dockerfile.PostgreSql -t proba/postgre-sql ../SQL

docker build --no-cache -f Dockerfile -t proba/app ../..
