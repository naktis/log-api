# Log API

API to read and save logs

## HTTP methods

- GET: api/logs
- GET: api/logs/id
- POST: api/logs (_LogDto_ object is passed through the request body)

### _LogDto_ Schema

```javascript
LogDto {
    timestamp: string($date-time),
    level: string,
    messageTemplate: string,
    renderedmessage: string,
    properties: { }
}
```

## Options

You can choose a place to store or read logs from by editing the options parameter in _appsettings.json_ file:

- Console
- Email
- File
- SQL database

If the chosen option is Console or Email, the API will return _405 Method Not Allowed_ error code to any GET request and only POST requests will get accepted.
