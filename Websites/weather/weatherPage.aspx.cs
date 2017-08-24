using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;


public partial class weatherPage : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /* This portion of code is executed when the submit button is clicked
     *  
     *  Instantiation of a new Service reference ndfdXML ~ for client's SOAP connection to the weather service
     *  
     *  Accept input from textboxes (Location coordinate)  
     *      --+ Latitude => lat
     *      --+ Longitude => lng
     *  
     *  Call the method for the current weather observation (NDFDgenByDay) from the weather service class
     *      --+ return result as a string
     *      --+ write the result to a file in form of XML
     *      --+ handle the appropriate nodes and get their values
     */
    protected void submitButton_Click(object sender, EventArgs e)
    {
        gov.weather.graphical.ndfdXML myweather = new gov.weather.graphical.ndfdXML();

        try
        {   // Get input form textboxes
            decimal lat = Decimal.Parse(txtLatitude.Text);           // latitude value
            decimal lng = Decimal.Parse(txtLongitude.Text);          // longitude value
            string numOfDays = "1";                                  // number of days for weather observations to be fetched

            
            gov.weather.graphical.weatherParametersType wth_para = new gov.weather.graphical.weatherParametersType();
            wth_para.temp = true;

            // call the method for the current observation (NDFDgenByDay) to get weather information
            string result = myweather.NDFDgenByDay(lat, lng, DateTime.UtcNow, numOfDays, gov.weather.graphical.unitType.e, gov.weather.graphical.formatType.Item12hourly);
            
            // define the directory path to write result (current observation) from the  national weather service station
            string result_path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "", "result.xml");

            // write the result to a file on the created path
            System.IO.StreamWriter file = new System.IO.StreamWriter(result_path);
            file.WriteLine(result);
            file.Close();


            XmlDocument result_xml = new XmlDocument();                 
            result_xml.Load(result_path);                              // load the XML file from the path

            // process the nodes needed from the XML file
            XmlNode max_temp_node = result_xml.SelectSingleNode("//data/parameters/temperature[@type ='maximum']/value/text()");
            XmlNode min_temp_node = result_xml.SelectSingleNode("//data/parameters/temperature[@type ='minimum']/value/text()");
            XmlNode prob_prep = result_xml.SelectSingleNode("//data/parameters/probability-of-precipitation/value/text()");
            XmlNode weather_icon = result_xml.SelectSingleNode("//data/parameters/conditions-icon/icon-link/text()");

            string maxTemperature = max_temp_node.Value;             // get maximum temperature value
            string minTemperature = min_temp_node.Value;             // get minimum temperature value
            string probOfPrepipitation = prob_prep.Value;            // get probability of precipitation value
            string weatherIcon = weather_icon.Value;                 // get the weather icon value

            // pass the corresponding values from the nodes to its specific label
            Label3.Text = maxTemperature;                            
            Label5.Text = minTemperature;
            Label10.Text = probOfPrepipitation;
            Label12.Text = "<img alt='' src='" + weatherIcon + "' />";
        }catch (Exception ex)
        {
                                                                                 
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('"+ ex.Message+ "')</SCRIPT>");
        }

    }
}