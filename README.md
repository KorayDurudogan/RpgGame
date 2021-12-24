# RpgGame 🎉

RpgGame solution contains five projects 🏗️
* **RpgGame.Command.Api** -> Contains endpoint where users connect the application about insert/update/delete transactions.
* **RpgGame.Command.Application** -> Contains business models about insert/update/delete transactions. It is a project where Command.API and Infrastructure projects meet. This layer consumes all resources from Infrastructure.
* **RpgGame.Query.Api** -> Contains endpoint where users connect the application about fetching data.
* **RpgGame.Query.Application** -> Contains business models about fetching data. It is a project where Query.API and Infrastructure projects meet. This layer consumes all resources from Infrastructure.
* **RpgGame.Infrastructure** -> Responsible for connection to MongoDb database.

Some features of the solution ✨

* Project uses MongoDB as database.
* APIs have swagger documentations.
* Projects use MediatR for redirecting requests.
* Solution designed with CQRS which means commands and queries are working via different applications.(But using the same database)
* Solution implements Event Sourcing pattern for fetching data of a specific time requested.

How to Run 🚀

* Run MongoDB at your local. Assign it's connection strings under both APIs' Startups.
* Project doesn't have any endpoint for inserting a _character_ data, so you should insert atleast one from MongDb Shell or MongoDb Compass

![Screen Shot 2021-12-12 at 20 50 19](https://user-images.githubusercontent.com/47561392/145766627-6f8492e0-db50-4ff0-a06f-55cb0ad177ae.png)
