# Order Organizer

Project name: OrderOrganizer

Project type: Windows Forms

Program, in which the application was created: Visual Studio 2017

Goal of the program: order management

## Used tools
- C#
- .Net
- Unit Tests

## User manual

![1](https://user-images.githubusercontent.com/40712810/54930385-7c507300-4f17-11e9-8184-96ba83f79bec.png)

### Nawigacja

The application can be navigated by clicking the appropriate buttons visible in the upper bar of the program or by pressing one of the lower buttons: 'Load external files', 'Visualization', 'Generate report'. 

### Ładowanie bazy danych

To load the database, first select the appropriate batch files (acceptable formats: .csv, .json, .xml) by clicking the 'Select File' button. This will display a dialog window from which we select the appropriate file (sample files are already in the OrderOrganizer / Orders folder). The name of the selected file will be displayed below the 'Select File' button. In order to protect the database against duplicate orders, it is not possible to add the same file twice - when the user tries to do so, an appropriate message will be displayed. Next, load selected files into the database - you do it by pressing the 'Load database' button. If you have not selected any files before, the application will not hesitate to inform us. The last button in this section - 'Clear database' allows the user to clear the database (including loaded files). If the loaded files contain incorrectly formatted order data, they will be displayed in the table above with additional information about the file from which they come.

![2](https://user-images.githubusercontent.com/40712810/54930479-a3a74000-4f17-11e9-926f-09605e12d6c1.png)

### Wizualizacja

Pressing the magnifying glass button switches to graphic database mode. The above table will display all orders that were correctly specified in the batch files. Clicking on the column name automatically sorts the table.

![3](https://user-images.githubusercontent.com/40712810/54930520-b28df280-4f17-11e9-96ab-b6bfa770e92f.png)

Above is the section responsible for generating reports. The choice of data to be included in the report is intuitive - in addition, the application watches over the correct selection of appropriate elements. Selecting one of the boxes placed in the 'Multiple data' group additionally unlocks the possibility of sorting selected orders according to the criterion from the group 'Group orders by'. Selecting 'Orders in price range' also allows you to enter the price range for orders. The report can also be personalized for a specific customer - to do so, enter his 'ClientID' in the text field preceded by 'Select client ID'. Before generating the report, specify its name (the default name is ExampleName). Report name cannot be left blank. We generate the report by pressing the pencil button. The created report will be saved to the OrderOrganizer / Reports / FileName.csv folder.
