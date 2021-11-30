# MD5Duplicate

This application is intended to compare new image deliveries with stored SQL checksums and remove duplicate files.

This will produce a net-change of images to review and process.


Please make sure to edit the "Properties/Settings.settings" file with your current SQL connection info and the select string.
  Add a "WHERE MFGCode = '"+mfgBox.text+"'" to the end of the SQL setting string to filter large data sets in SQL checksum table.
You'll also need to confirm all datatable columns in the main.cs file match your SQL select columns.
  
  
  Broken? - ToDo:
  If the images you unzipped reside in a sub-folder outside of the selected zip directory, 
  you'll need to unzip the images manually then use the 'Folder' options to navigate to and select the literal path of the images.
