# Using MailHog via Docker for testing email

It is set up to send email via SMTP and so the easiest way to do this for me was to add a local MailHog instance and point the application at it.
 
## Manually running via Docker
The quickest and easiest way to do this is via Docker.

Manually, we can do:

```console
 docker run -p 8025:8025 -p 1025:1025 mailhog/mailhog
 ```
 
## Docker compose

mailhog.yaml content as below

```console
services:
  mailhog:
    image: mailhog/mailhog
    logging:
      driver: 'none'  # disable saving logs
    ports:
      - 1025:1025 # smtp server
      - 8025:8025 # web ui, api
```

## Docker up 
make running/up the mailhog service using below command.
```console
docker compose -f ./mailhog.yaml up
```
# Usage
## MailHog UI Default
Once the container is running you can access the web UI at

<a htef='http://localhost:8025' />http://localhost:8025</a>
