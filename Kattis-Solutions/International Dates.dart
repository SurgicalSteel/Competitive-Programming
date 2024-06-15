import 'dart:io';
 
void main() {
    String? raw = stdin.readLineSync();
    var splitted = raw!.split("/");
    var a = int.parse(splitted[0]);
    var b = int.parse(splitted[1]);
    if (a<=12 && b <=12){
        print("either");
    }else{
        if(a>12 && b <=12){print("EU");}else if(a<=12 && b>12){print("US");}
    }
    
}
