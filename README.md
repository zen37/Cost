# Cost

Auto Updating Created, Updated and Deleted Timestamps In Entity Framework
https://dotnetcoretutorials.com/2022/03/16/auto-updating-created-updated-and-deleted-timestamps-in-entity-framework/

How do you model a table for unit conversion?

https://stackoverflow.com/questions/3956044/how-do-you-model-a-table-for-unit-conversion
https://stackoverflow.com/questions/27952006/how-should-i-handle-units-of-measure-in-an-ingredient-database

Conversion
https://www.rapidtables.com/convert/
https://www.unitconverters.net/

Form validation
https://stackoverflow.com/questions/69724492/blazor-editform-custom-validation-message-on-form-submission



https://trystanwilcock.com/2022/02/06/how-to-get-the-current-user-in-blazor-c/

Blazor <InputSelect> inside <EditForm>?
https://stackoverflow.com/questions/71477626/blazor-inputselect-inside-editform

##lessons
error creating db: 
"Introducing FOREIGN KEY constraint 'FK_ComponentProduct_Products_ProductsId' on table 'ComponentProduct' may cause cycles or multiple cascade paths. Specify ON DELETE NO ACTION or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints."


fix: 
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentProduct", x => new { x.ComponentsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ComponentProduct_Components_ComponentsId",
                        column: x => x.ComponentsId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    // onDelete: ReferentialAction.Cascade);

