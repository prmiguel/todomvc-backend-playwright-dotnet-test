# todomvc-backend-playwright-dotnet-test

```sh
docker compose -f ci/compose.yml up -d
docker compose -f ci/compose.yml -f ci/compose.test.yml up workflow
```


```sh
docker run \
-v /var/run/docker.sock:/var/run/docker.sock  \
-v $PWD:/data \
--user root:root \
--rm \
--network todomvc-backend-playwright-dotnet-test_ci \
--link forgejo \
code.forgejo.org/forgejo/runner:9.1.0 \
forgejo-runner register --no-interactive --token K8JQcc7W4eAG92Oieq8Ru9rw1vy5i9sGdmLvg3er --name testdock --instance http://forgejo:3000
```

```sh
docker run \
-v /var/run/docker.sock:/var/run/docker.sock  \
-v $PWD:/data \
--rm \
code.forgejo.org/forgejo/runner:9.1.0 \
forgejo-runner generate-config > config.yml
```

```sh
docker run -d \
-v /var/run/docker.sock:/var/run/docker.sock \
--user root:root \
-v $PWD:/data \
--network todomvc-backend-playwright-dotnet-test_ci \
--link forgejo \
--rm \
code.forgejo.org/forgejo/runner:9.1.0 \
forgejo-runner --config config.yml daemon
```
