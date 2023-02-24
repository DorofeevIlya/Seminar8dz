// 88. Заменить все вхождения подстроки w в строке st на строку v. 
// Вывести на экран первоначальную строку и конечную строку

string st ="Добрый кот Том! Добрый мышонок Джерри!";
System.Console.WriteLine(st);
System.Console.WriteLine();
string w ="Добрый";
string v ="Злой";
st = st.Replace(w,v);
System.Console.WriteLine(st);

