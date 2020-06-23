function demoPDF() {
    var doc = new jsPDF();
    doc.text(10, 10, 'Hello everybody');



    doc.setFont("times");
	
    doc.setFontType("italic");
   
   
    			
    doc.setFontType("bold");
    doc.setTextColor(255,0,0);					//set font color to red
 
   
    

    doc.addPage(); 						// add new page in pdf
    
    doc.setTextColor(165,0,0);
    doc.text(10, 20, 'extra page to write');

    doc.save('katara.pdf');					 // Save the PDF with name "katara"...
}

