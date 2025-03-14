# DMR.NET

DMR.NET is a package designed to help developers interact with the data provided by the Danish Vehicle Registry (DMR). Its primary goal is to provide the logic for downloading and parsing DMR data, enabling developers to create their own services that can ingest this data and store it in their own databases for faster retrieval and processing. By using DMR.NET, developers can easily integrate DMR data into their applications and optimize access to vehicle-related information.

## NuGet Packages

### DMR.NET

The DMR.NET package provides the logic to download the latest DMR database from an FTP server and parse it into usable models. It includes functionality for interacting with the DMR database, enabling easy retrieval and processing of DMR data.

### DMR.NET.Entities

The DMR.NET.Entities package provides the data models used by the DMR.NET project. It includes all the necessary entities that represent the structure of the DMR data.

## How it works

DMR has a publicly available database with all vehicles. The database is an 100+ GB XML file located on an FTP server. DMR.NET can download the latest DMR database to the local machine, and parse the DMR entries as objects.

## Configuration

Credentials can be [found here](https://motorst.dk/erhverv/motorregistret-for-virksomheder/faa-adgang-til-motorregistret/andre-adgange) under "Statistikudtræk". The configuration below should work as long as the credentials hasn't been changed. DMR.NET has an included [DmrFtpOptions](DMR.NET/Options/DmrFtpOptions.cs) model.

```json
{
  "DmrFtp": {
    "Host": "5.44.137.84",
    "Username": "dmr-ftp-user",
    "Password": "dmrpassword",
    "SourcePath": "/ESStatistikListeModtag/",
    "DestinationPath": "/home/user/dmr/"
  }
}
```

## Example Usage

### [DMR2Mongo](https://github.com/j4asper/DMR2Mongo)

DMR2Mongo is a simple service that checks for updates to the DMR database, downloads the latest available data, parses the objects, and stores them in a MongoDB database.

## Contributing and Limitations

### Incomplete DMR Properties
Please note that the project does **not** yet contain all the properties defined by the DMR (Dansk Motor Register) schema. While we have implemented a significant portion of the properties, there are still many to be added. We encourage and greatly appreciate contributions to expand the coverage of DMR properties. If you find missing properties or encounter any issues, feel free to open a pull request or raise an issue!

### Testing
Currently, the project is **not thoroughly tested**, and we are actively working to improve test coverage. If you encounter any bugs or unexpected behavior, we welcome feedback and contributions to help us improve the quality and reliability of the project.

### How to Contribute
We highly appreciate any contributions to this project! Whether it's adding missing properties, improving code quality, or enhancing tests, your contributions will help make this project more robust. Please follow these steps to contribute:
1. Fork the repository.
2. Create a new branch for your changes.
3. Implement your changes, making sure to adhere to the coding style of the project.
4. Run existing tests and add new ones if necessary.
5. Submit a pull request with a clear description of the changes.
