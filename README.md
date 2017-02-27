# bagit_sharp
bagit-sharp is a C# library for working with [BagIt] (http://purl.org/net/bagit) style packages.  It's functionality loosely tries to emulate the functionality found in the [bagit-python] (https://github.com/LibraryOfCongress/bagit-python) project

## Dependencies
The project makes use of the [icsharpcode/SharpZipLib] (https://github.com/icsharpcode/SharpZipLib) project.  

## Installation
The project includes a Visual Studio project file.  To build a binary library from the code you will need to:

1. Download a binary or build a binary of the [SharpZipLib] (https://github.com/icsharpcode/SharpZipLib) library
2. Open the project in [Visual Studio] (https://www.visualstudio.com/downloads/) or compatible tool
3. Ensure a reference to the SharpZipLib
4. Build

To simplify use, there is also a binary copy available via Release that includes binaries of both the bagit-sharp library and the referenced SharpZipLib code that it's built against.

## Usage

The Library provides an object representation of a bag.  This includes properties, etc.  To create a new bag:

```csharp
bagit_sharp.Bag objB = new bagit_sharp.Bag();
//Create an event handler to handle updates 
//from the library
objB.UpdateStatus += ObjB_UpdateStatus;

objB.Contact_Name = "Your Contact Name";
objB.Organization_Address = "Your Address, Your City, Your State";
objB.Contact_Email = "your_email@gmail.com";
bagit_sharp.Bag.CHECKSUM_ALGOS checksum = bagit_sharp.Bag.CHECKSUM_ALGOS.md5;

string[] objects_to_bag = new string[2] {"D:\folder1\", "D:\folder2\"};
bagit_sharp.Bag mybag = objB.Make_Bag(objects_to_bag, "D:\Bags\new_bag\", null, 1, checksum);
if (mybag != null) {
   MessageBox.Show("Bag Created");
} else {
   MessageBox.Show("Bag not created: " + objB.ErrorMessage);
}
```

If you wish to load a bag to zip or to validate

```csharp
bagit_sharp.Bag objB = new bagit_sharp.Bag("D:\Bags\new_bag\");
```

To Validate
```csharp
try {
  bagit_sharp.Bag objB = new bagit_sharp.Bag("D:\Bags\new_bag\");
  objB.Validate_Bag();
} catch (bagit_sharp.BagException ex)
{
  MessageBox.Show(ex.Message);
}
MessageBox.Show("Valid!");
```

To Zip:
```csharp
bagit_sharp.Bag objB = new bagit_sharp.Bag("D:\Bags\new_bag\");
if (objB.ZipFile() == false) {
  MessageBox.Show("Zip not successful");
} else {
  MessageBox.Show("Bag was Zipped");
}
```

When zipping a file, the zip file is created at the same level as the top bag folder.  With the zip file, a checksum file will also be created, utilizing MD5 as the default.


## Supported Checksums

The bagit_sharp library supports the following common checksums
1. MD5
2. SH1
3. SH256
4. SH384
5. SH512

## Update a bag manifest: 
ToDo

## Contributing to the bagit_sharp development

I invite anyone that is interested to clone the project, make changes, and submit the changes back to project.  

### Testing
ToDo

License: 

MIT License



