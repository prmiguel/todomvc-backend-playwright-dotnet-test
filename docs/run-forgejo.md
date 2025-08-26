# Run Forgejo

```sh
docker compose -f ci/compose.yml -f ci/compose.forgejo.yml up -d
docker compose -f ci/compose.yml -f ci/compose.forgejo.yml -f ci/compose.workflow.yml up workflow
```
