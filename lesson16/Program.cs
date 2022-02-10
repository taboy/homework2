  
 ​//​ Дано число обозначающее день недели. Выяснить является номер дня недели выходным
 ​int​ ​D​; 
 ​Console​.​WriteLine​(​"​ ​Enter the number of the day of the week"​); 
 ​D​ ​=​ ​Convert​.​ToInt32​(​Console​.​ReadLine​()); 
 ​if​ (​D​ ​>​ ​5​ ​&&​ ​D​ ​<​ ​8​)  
 ​{ 
 ​    ​Console​.​Write​(​"​Weekend "​); 
 ​    ​if​ (​D​ ​==​ ​6​) 
 ​    { 
 ​        ​Console​.​WriteLine​(​"​Saturday ​"​); 
 ​    } 
 ​    ​if​ (​D​ ​==​ ​7​) 
 ​    { 
 ​        ​Console​.​WriteLine​(​"​Sunday ​"​); 
 ​    } 
 ​} 
 ​else​ ​if​ (D > 0 && D < 5) 
 ​{ 
 ​    ​Console​.​WriteLine​(​"​Weekday ​"​); 
 ​} 
 ​else​  
 ​Console​.​WriteLine​(​"There are 7 days in a week"​);
