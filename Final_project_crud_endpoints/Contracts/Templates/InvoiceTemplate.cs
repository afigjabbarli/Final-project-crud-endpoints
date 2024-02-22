using Final_project_crud_endpoints.DataBase.DTOs.Order;
using System.Collections.Generic;
using System.Text;

namespace Final_project_crud_endpoints.Contracts.Templates
{
    public static class InvoiceTemplate
    {
        public static string GenerateInvoiceHtml(OrderDetailsDTO DTO)
        {
            StringBuilder htmlBuilder = new StringBuilder();

            htmlBuilder.Append($@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
</head>
<body style=""margin: 0px; padding: 0px; box-sizing: border-box;"">
    <header style=""width: 100%;"">
        <div style=""width: 96%; margin: 0px auto;"" class=""container"">
            <div style=""width: 100%; padding: 30px 0px;"" class=""row"">
                 <div style=""width: 100%; display: flex; align-items: center; justify-content: space-between; padding: 25px 0px; border-bottom: 1px solid black;"" class=""provider"">
                       <div style=""width: 250px; height: 100px;"" class=""image"">
                             <img style=""width: 100%; height: 100%; border-radius: 16px;"" src=""./Emblem-Walmart.jpg"" alt="""">
                       </div>
                       <div style=""display: flex; align-items: center; justify-content: center; color: #0071DC; font-size: 20px;"" class=""Provider-name""><h1>Walmart E-Commerce</h1></div>
                       <div style=""display: flex; align-items: center; justify-content: flex-end; font-size: 24px; font-weight: bold; letter-spacing: 2px;""><p>{DTO.Order_Tracking_Code}</p></div>
                 </div>

                 <div style=""width: 100%; padding: 15px 0px; display: flex; align-items: center; justify-content: center;"">
                     <div style=""display: flex; margin: 0px 30px; font-size: 18px; font-weight: bold;""><p style=""margin-right: 15px;"">Invoice ID: </p><p>{DTO.Order_ID}</p></div>
                     <div style=""display: flex; margin: 0px 30px; font-size: 18px; font-weight: bold;""><p style=""margin-right: 15px;"">Invoice Date: </p><p>{DTO.Order_Created_At}</p></div>
                     <div style=""display: flex; margin: 0px 30px; font-size: 18px; font-weight: bold;""><p style=""margin-right: 15px;"">Order status: </p><p>{DTO.Current_Order_Status}</p></div>
                 </div>

                 <div style=""width: 100%; padding: 15px 0px; display: flex; align-items: center; justify-content: center;"">
                    <div style=""display: flex; margin: 0px 30px; font-size: 18px; font-weight: bold;""><p style=""margin-right: 15px;"">Customer fullname: </p><p>{DTO.Current_User_Name + " " + DTO.Current_User_Surname}</p></div>
                    <div style=""display: flex; margin: 0px 30px; font-size: 18px; font-weight: bold;""><p style=""margin-right: 15px;"">Customer email address: </p><p>{DTO.Current_User_Email}</p></div>
                    <div style=""display: flex; margin: 0px 30px; font-size: 18px; font-weight: bold;""><p style=""margin-right: 15px;"">Customer phone number: </p><p>{DTO.Current_User_Phone_Number}</p></div>
                </div>

                <div style=""width: 100%; padding: 15px 0px; display: flex; align-items: center; justify-content: center;"">
                    <div style=""display: flex; margin: 0px 30px; font-size: 18px; font-weight: bold;""><p style=""margin-right: 15px;"">Address: </p><p>Sacramento, 95829 Sacramento Supercenter</p></div>
                    <div style=""display: flex; margin: 0px 30px; font-size: 18px; font-weight: bold;""><p style=""margin-right: 15px;"">Contact: </p><p>+18002500668</p></div>
                </div>
            </div>
        </div>
    </header>
    <main style=""font-family: Arial, sans-serif; margin: 0; padding: 0;"">
        
            <div style=""width: 96%; margin: auto; padding: 20px; box-shadow: 0px 0px 10px 15px rgba(0,0,0,0.1); border-radius: 10px; overflow: hidden;"">
                <h1 style=""text-align: center; color: #333;"">Order Details</h1>
                <table style=""width: 100%; border-collapse: collapse; margin-top: 20px;"">
                    <tr>
                        <th style=""border: 1px solid #9c9c9c; background-color: rgb(58, 57, 57); color: white; text-align: left; padding: 12px;"">#</th>
                        <th style=""border: 1px solid #9c9c9c; background-color: rgb(58, 57, 57); color: white; text-align: left; padding: 12px;"">Product Code</th>
                        <th style=""border: 1px solid #9c9c9c; background-color: rgb(58, 57, 57); color: white; text-align: left; padding: 12px;"">Category</th>
                        <th style=""border: 1px solid #9c9c9c; background-color: rgb(58, 57, 57); color: white; text-align: left; padding: 12px;"">Brand</th>
                        <th style=""border: 1px solid #dddddd; background-color: rgb(58, 57, 57); color: white; text-align: left; padding: 12px;"">Product Name</th>
                        <th style=""border: 1px solid #dddddd; background-color: rgb(58, 57, 57); color: white; text-align: left; padding: 12px;"">Quantity</th>
                        <th style=""border: 1px solid #dddddd; background-color: rgb(58, 57, 57); color: white; text-align: left; padding: 12px;"">Single Price</th>
                        <th style=""border: 1px solid #dddddd; background-color: rgb(58, 57, 57); color: white; text-align: left; padding: 12px;"">Total Price</th>
                        <th style=""border: 1px solid #dddddd; background-color: rgb(58, 57, 57); color: white;; text-align: left; padding: 12px;"">Image</th>
                    </tr>");

            int count = 0;
            foreach (var Order_Item_Details_DTO in DTO.Order_Item_Details_DTOs)
            {
                count++;
                htmlBuilder.Append($@"<tr>
                        <td>{count}</td>
                        <td>{Order_Item_Details_DTO.Product_Code}</td>
                        <td>{Order_Item_Details_DTO.Category_Name}</td>
                        <td>{Order_Item_Details_DTO.Brand_Name}</td>
                        <td>{Order_Item_Details_DTO.Product_Name}</td>
                        <td>{Order_Item_Details_DTO.Quantity}</td>
                        <td>{Order_Item_Details_DTO.Order_Item_Single_Price}</td>
                        <td>{Order_Item_Details_DTO.Order_Item_Total_Price}</td>
                        <td><img src=""{Order_Item_Details_DTO.Phisical_Image_URL}"" alt=""Product Image"" style=""max-width: 100px; max-height: 100px; display: block; margin: auto;""></td>
                    </tr>");
            }

            htmlBuilder.Append($@"</table>
            </div>
        
    </main>
    <footer style=""width: 100%;"">
        
        <div style=""width: 96%; margin: 0px auto;"" class=""container"">
            <div style=""width: 100%; padding: 30px 0px; display: flex; align-items: center; justify-content: flex-end;"" class=""row"">
                 <div style=""display: flex; align-items: center; width: 25%; font-size: 36px; border-radius: 16px; justify-content: center; background-color: #333; color: white; padding: 0px 25px;""><p>Summary Total: </p><p style=""margin-left: 10px;"">{DTO.Summary_Total}</p><span>$</span></div>
            </div>
        </div>

    </footer>
</body>
</html>");

            return htmlBuilder.ToString();
        }

    }
}
