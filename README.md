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
--network ci_default \
--link forgejo \
code.forgejo.org/forgejo/runner:9.0.1 \
forgejo-runner register --no-interactive --token yQVIu4hHbXy003vgXwm0spU3Xs892a75SEKZs0hZ --name testdock --instance http://forgejo:3000
```

```sh
docker run \
-v /var/run/docker.sock:/var/run/docker.sock  \
-v $PWD:/data \
--rm \
code.forgejo.org/forgejo/runner:9.0.1 \
forgejo-runner generate-config > config.yml
```

```sh
docker run -d \
-v /var/run/docker.sock:/var/run/docker.sock \
--user root:root \
-v $PWD:/data \
--network ci_default \
--link forgejo \
--rm \
code.forgejo.org/forgejo/runner:9.0.1 \
forgejo-runner --config config.yml daemon
```
