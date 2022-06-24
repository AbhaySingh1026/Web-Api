All Important Theory & cmnds are in this link - https://techabhimanyu.blogspot.com/2022/06/basics-of-web-api.html

If their r more than 1 methods put haing diff HTTP verbs then in running u will not face any prblm it will automatically open the 1st method and then in same URL u can open another method
or & if u want to open swagger then also write above link cmd for swagger it will open. Or u can set default path as swagger so it will default open & their u can see all ur diff. verbs method

Prblm occurs when their r 2 or more than 2 methods of same verbs then even swagger will not open & also it will not open any method & u can also not play with url to open those methods
So to fix this u should add \[Action] so now it tells that only controller is not req. but method name is also req. so now u can go & set launch Url as = controllername//method_name

so it will default open that method & in that opened web if u replace method name with another method name it will open that & also then from that url using proper syntax u can open swagger

but this is not good practice coz if u have 10 method of same verbs then u have to write launch url for all or explicitly u have to go in opened web method & their u have to enter each method
name u want to see.

So, to do it efficiently just set launch url as swagger so now this time it show all methods with diff & same verbs at one place & even u can test each one of them.

IN THIS PROJECT EMPLOYEE AND WEATHER FORECAST ARE KNOWS AS MODEL

AND VIEW IS NOT PRESENT IN THIS AS THIS IS API, IT WILL BE PRESENT IN WEB APP.