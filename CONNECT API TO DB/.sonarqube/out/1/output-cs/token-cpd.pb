ö
îE:\KelltonTech\.NET training kellton\Real Training Started\AllAssignmentsAfterGaneshLeft\Web-Api\CONNECT API TO DB\API\ApiModel\ClassRoomApiModel.cs
	namespace 	
API
 
. 
ApiModel 
{ 
public 

class 
ClassRoomApiModel "
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
? 
Name 
{ 
get !
;! "
set# &
;& '
}( )
} 
} Ù
ûE:\KelltonTech\.NET training kellton\Real Training Started\AllAssignmentsAfterGaneshLeft\Web-Api\CONNECT API TO DB\API\ApiModel\TeacherAndClassRoomApiModel.cs
	namespace 	
API
 
. 
ApiModel 
{ 
public 

class '
TeacherAndClassRoomApiModel ,
{ 
public 
List 
< 
ClassRoomApiModel %
>% &
ClassRoomList' 4
{5 6
get7 :
;: ;
set< ?
;? @
}A B
public 
TeacherApiModel 
Teacher &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
} 
} ñ
íE:\KelltonTech\.NET training kellton\Real Training Started\AllAssignmentsAfterGaneshLeft\Web-Api\CONNECT API TO DB\API\ApiModel\TeacherApiModel.cs
	namespace 	
API
 
. 
ApiModel 
{ 
public 

class 
TeacherApiModel  
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
? 
Name 
{ 
get !
;! "
set# &
;& '
}( )
} 
} ¡;
ôE:\KelltonTech\.NET training kellton\Real Training Started\AllAssignmentsAfterGaneshLeft\Web-Api\CONNECT API TO DB\API\Controllers\EmployeesController.cs
	namespace 	
API
 
. 
Controllers 
{ 
[ 
Route 

(
 
$str 
) 
] 
[		 
ApiController		 
]		 
public

 

class

 
EmployeesController

 $
:

% &
ControllerBase

' 5
{ 
private 
readonly 
ApiDbContext %
_context& .
;. /
public 
EmployeesController "
(" #
ApiDbContext# /
context0 7
)7 8
{ 	
_context 
= 
context 
; 
} 	
[ 	
HttpGet	 
] 
public 
async 
Task 
< 
ActionResult &
<& '
IEnumerable' 2
<2 3
Employee3 ;
>; <
>< =
>= >
GetEmployees? K
(K L
)L M
{ 	
if
 
( 
_context 
. 
	Employees  
==! #
null$ (
)( )
{
 
return 
NotFound 
( 
) 
;  
}
 
return 
await 
_context !
.! "
	Employees" +
.+ ,
ToListAsync, 7
(7 8
)8 9
;9 :
} 	
[ 	
HttpGet	 
( 
$str 
) 
] 
public 
async 
Task 
< 
ActionResult &
<& '
Employee' /
>/ 0
>0 1
GetEmployee2 =
(= >
int> A
idB D
)D E
{ 	
if
 
( 
_context 
. 
	Employees  
==! #
null$ (
)( )
{  
 
return!! 
NotFound!! 
(!! 
)!! 
;!!  
}""
 
var## 
employee## 
=## 
await##  
_context##! )
.##) *
	Employees##* 3
.##3 4
	FindAsync##4 =
(##= >
id##> @
)##@ A
;##A B
if$$ 
($$ 
employee$$ 
==$$ 
null$$  
)$$  !
{%% 
return&& 
NotFound&& 
(&&  
)&&  !
;&&! "
}'' 
return(( 
employee(( 
;(( 
})) 	
[,, 	
HttpPut,,	 
(,, 
$str,, 
),, 
],, 
public-- 
async-- 
Task-- 
<-- 
IActionResult-- '
>--' (
PutEmployee--) 4
(--4 5
int--5 8
id--9 ;
,--; <
Employee--= E
employee--F N
)--N O
{.. 	
if// 
(// 
id// 
!=// 
employee// 
.// 
Id// !
)//! "
{00 
return11 

BadRequest11 !
(11! "
)11" #
;11# $
}22 
_context33 
.33 
Entry33 
(33 
employee33 #
)33# $
.33$ %
State33% *
=33+ ,
EntityState33- 8
.338 9
Modified339 A
;33A B
try44 
{55 
await66 
_context66 
.66 
SaveChangesAsync66 /
(66/ 0
)660 1
;661 2
}77 
catch88 
(88 (
DbUpdateConcurrencyException88 /
)88/ 0
{99 
if:: 
(:: 
!:: 
EmployeeExists:: #
(::# $
id::$ &
)::& '
)::' (
{;; 
return<< 
NotFound<< #
(<<# $
)<<$ %
;<<% &
}== 
else>> 
{?? 
throw@@ 
;@@ 
}AA 
}BB 
returnCC 
	NoContentCC 
(CC 
)CC 
;CC 
}DD 	
[GG 	
HttpPostGG	 
]GG 
publicHH 
asyncHH 
TaskHH 
<HH 
ActionResultHH &
<HH& '
EmployeeHH' /
>HH/ 0
>HH0 1
PostEmployeeHH2 >
(HH> ?
EmployeeHH? G
employeeHHH P
)HHP Q
{II 	
ifJJ
 
(JJ 
_contextJJ 
.JJ 
	EmployeesJJ  
==JJ! #
nullJJ$ (
)JJ( )
{KK
 
returnLL 
ProblemLL 
(LL 
$strLL L
)LLL M
;LLM N
}MM
 
_contextNN 
.NN 
	EmployeesNN 
.NN 
AddNN "
(NN" #
employeeNN# +
)NN+ ,
;NN, -
awaitOO 
_contextOO 
.OO 
SaveChangesAsyncOO +
(OO+ ,
)OO, -
;OO- .
returnPP 
CreatedAtActionPP "
(PP" #
$strPP# 0
,PP0 1
newPP2 5
{PP6 7
idPP8 :
=PP; <
employeePP= E
.PPE F
IdPPF H
}PPI J
,PPJ K
employeePPL T
)PPT U
;PPU V
}QQ 	
[TT 	

HttpDeleteTT	 
(TT 
$strTT 
)TT 
]TT 
publicUU 
asyncUU 
TaskUU 
<UU 
IActionResultUU '
>UU' (
DeleteEmployeeUU) 7
(UU7 8
intUU8 ;
idUU< >
)UU> ?
{VV 	
ifWW 
(WW 
_contextWW 
.WW 
	EmployeesWW "
==WW# %
nullWW& *
)WW* +
{XX 
returnYY 
NotFoundYY 
(YY  
)YY  !
;YY! "
}ZZ 
var[[ 
employee[[ 
=[[ 
await[[  
_context[[! )
.[[) *
	Employees[[* 3
.[[3 4
	FindAsync[[4 =
([[= >
id[[> @
)[[@ A
;[[A B
if\\ 
(\\ 
employee\\ 
==\\ 
null\\  
)\\  !
{]] 
return^^ 
NotFound^^ 
(^^  
)^^  !
;^^! "
}__ 
_context`` 
.`` 
	Employees`` 
.`` 
Remove`` %
(``% &
employee``& .
)``. /
;``/ 0
awaitaa 
_contextaa 
.aa 
SaveChangesAsyncaa +
(aa+ ,
)aa, -
;aa- .
returnbb 
	NoContentbb 
(bb 
)bb 
;bb 
}cc 	
privateee 
boolee 
EmployeeExistsee #
(ee# $
intee$ '
idee( *
)ee* +
{ff 	
returngg 
(gg 
_contextgg 
.gg 
	Employeesgg &
?gg& '
.gg' (
Anygg( +
(gg+ ,
egg, -
=>gg. 0
egg1 2
.gg2 3
Idgg3 5
==gg6 8
idgg9 ;
)gg; <
)gg< =
.gg= >
GetValueOrDefaultgg> O
(ggO P
)ggP Q
;ggQ R
}hh 	
}ii 
}jj πT
òE:\KelltonTech\.NET training kellton\Real Training Started\AllAssignmentsAfterGaneshLeft\Web-Api\CONNECT API TO DB\API\Controllers\TeachersController.cs
	namespace 	
API
 
. 
Controllers 
{		 
[

 
Route

 

(


 
$str

 
)

 
]

 
[ 
ApiController 
] 
public 

class 
TeachersController #
:$ %
ControllerBase& 4
{ 
private 
readonly 
ApiDbContext %
_context& .
;. /
private 
readonly 
IMapper  
_mapper! (
;( )
public 
TeachersController !
(! "
ApiDbContext" .
context/ 6
,6 7
IMapper7 >
mapper? E
)E F
{ 	
_context 
= 
context 
; 
_mapper 
= 
mapper 
; 
} 	
[ 	
HttpGet	 
] 
public 
async 
Task 
< 
ActionResult &
<& '
IEnumerable' 2
<2 3
Teacher3 :
>: ;
>; <
>< =
GetTeachers> I
(I J
)J K
{ 	
if
 
( 
_context 
. 
Teachers 
==  "
null# '
)' (
{
 
return 
	NoContent 
( 
)  
;  !
}
 
var 
teacherList 
= 
_context '
.' (
Teachers( 0
.0 1
Include1 8
(8 9
c9 :
=>; =
c> ?
.? @

ClassRooms@ J
)J K
.K L
ToListL R
(R S
)S T
;T U
return 
teacherList 
; 
} 	
[!! 	
HttpGet!!	 
(!! 
$str!! 
)!! 
]!!  
public"" 
async"" 
Task"" 
<"" 
ActionResult"" &
<""& '
Teacher""' .
>"". /
>""/ 0

GetTeacher""1 ;
(""; <
int""< ?
	teacherId""@ I
)""I J
{## 	
if$$
 
($$ 
_context$$ 
.$$ 
Teachers$$ 
==$$  "
null$$# '
)$$' (
{%%
 
return&& 
	NoContent&& 
(&& 
)&&  
;&&  !
}''
 
var(( 
teacher(( 
=(( 
_context(( "
.((" #
Teachers((# +
.((+ ,
Where((, 1
(((1 2
t((2 3
=>((4 6
t((7 8
.((8 9
Id((9 ;
==((< >
	teacherId((? H
)((H I
.((I J
Include((J Q
(((Q R
c((R S
=>((T V
c((W X
.((X Y

ClassRooms((Y c
)((c d
.((d e
FirstOrDefault((e s
(((s t
)((t u
;((u v
if)) 
()) 
teacher)) 
==)) 
null)) 
)))  
{** 
return++ 
NotFound++ 
(++  
)++  !
;++! "
},, 
return-- 
teacher-- 
;-- 
}.. 	
[00 	
HttpPut00	 
(00 
$str00 
)00 
]00  
public11 
async11 
Task11 
<11 
ActionResult11 &
<11& '
Teacher11' .
>11. /
>11/ 0

PutTeacher111 ;
(11; <
int11< ?
	teacherId11@ I
,11I J'
TeacherAndClassRoomApiModel11K f
teacherAndClassRoom11g z
)11z {
{22 	
if33 
(33 
_context33 
.33 
Teachers33 !
==33" $
null33% )
)33) *
{44 
return55 
	NoContent55  
(55  !
)55! "
;55" #
}66 
var77 
updateTeacher77 
=77 
_context77  (
.77( )
Teachers77) 1
.771 2
Where772 7
(777 8
t778 9
=>77: <
t77= >
.77> ?
Id77? A
==77B D
	teacherId77E N
)77N O
.77O P
Include77P W
(77W X
c77X Y
=>77Z \
c77] ^
.77^ _

ClassRooms77_ i
)77i j
.77j k
FirstOrDefault77k y
(77y z
)77z {
;77{ |
if88 
(88 
updateTeacher88 
==88  
null88! %
)88% &
{99 
return:: 
NotFound:: 
(::  
)::  !
;::! "
};; 
updateTeacher<< 
.<< 
Name<< 
=<<  
teacherAndClassRoom<<! 4
.<<4 5
Teacher<<5 <
.<<< =
Name<<= A
;<<A B
updateTeacher== 
.== 

ClassRooms== $
===% &
_mapper==' .
.==. /
Map==/ 2
<==2 3
List==3 7
<==7 8
	ClassRoom==8 A
>==A B
>==B C
(==C D
teacherAndClassRoom==D W
.==W X
ClassRoomList==X e
)==e f
;==f g
_context>> 
.>> 
Teachers>> 
.>> 
Update>> $
(>>$ %
updateTeacher>>% 2
)>>2 3
;>>3 4
await?? 
_context?? 
.?? 
SaveChangesAsync?? +
(??+ ,
)??, -
;??- .
return@@ 
Ok@@ 
(@@ 
)@@ 
;@@ 
}AA 	
[CC 	
HttpPostCC	 
]CC 
publicDD 
asyncDD 
TaskDD 
<DD 
ActionResultDD &
<DD& '
TeacherDD' .
>DD. /
>DD/ 0
PostTeacherDD1 <
(DD< ='
TeacherAndClassRoomApiModelDD= X
teacherAndClassRoomDDY l
)DDl m
{EE 	
ifFF
 
(FF 
_contextFF 
.FF 
TeachersFF 
==FF  "
nullFF# '
)FF' (
{GG
 
returnHH 
	NoContentHH 
(HH 
)HH  
;HH  !
}II
 
varQQ 
teacherQQ 
=QQ 
_mapperQQ !
.QQ! "
MapQQ" %
<QQ% &
TeacherQQ& -
>QQ- .
(QQ. /
teacherAndClassRoomQQ/ B
.QQB C
TeacherQQC J
)QQJ K
;QQK L
varRR 
classroomListRR 
=RR 
_mapperRR  '
.RR' (
MapRR( +
<RR+ ,
ListRR, 0
<RR0 1
	ClassRoomRR1 :
>RR: ;
>RR; <
(RR< =
teacherAndClassRoomRR= P
.RRP Q
ClassRoomListRRQ ^
)RR^ _
;RR_ `
teacherSS 
.SS 

ClassRoomsSS 
=SS  
classroomListSS! .
;SS. /
_contextTT 
.TT 
TeachersTT 
.TT 
AddTT !
(TT! "
teacherTT" )
)TT) *
;TT* +
awaitUU 
_contextUU 
.UU 
SaveChangesAsyncUU +
(UU+ ,
)UU, -
;UU- .
returnVV 
OkVV 
(VV 
)VV 
;VV 
}WW 	
[YY 	

HttpDeleteYY	 
(YY 
$strYY !
)YY! "
]YY" #
publicZZ 
asyncZZ 
TaskZZ 
<ZZ 
IActionResultZZ '
>ZZ' (
DeleteTeacherZZ) 6
(ZZ6 7
intZZ7 :
	teacherIdZZ; D
)ZZD E
{[[ 	
if\\ 
(\\ 
_context\\ 
.\\ 
Teachers\\ !
==\\" $
null\\% )
)\\) *
{]] 
return^^ 
	NoContent^^  
(^^  !
)^^! "
;^^" #
}__ 
var`` 
teacher`` 
=`` 
await`` 
_context``  (
.``( )
Teachers``) 1
.``1 2
	FindAsync``2 ;
(``; <
	teacherId``< E
)``E F
;``F G
ifaa 
(aa 
teacheraa 
==aa 
nullaa 
)aa  
{bb 
returncc 
NotFoundcc 
(cc  
)cc  !
;cc! "
}dd 
_contextee 
.ee 
Teachersee 
.ee 
Removeee $
(ee$ %
teacheree% ,
)ee, -
;ee- .
awaitff 
_contextff 
.ff 
SaveChangesAsyncff +
(ff+ ,
)ff, -
;ff- .
returngg 
	NoContentgg 
(gg 
)gg 
;gg 
}hh 	
[ii 	
	HttpPatchii	 
(ii 
$strii  
)ii  !
]ii! "
publicjj 
asyncjj 
Taskjj 
<jj 
IActionResultjj '
>jj' (
PatchTeacherjj) 5
(jj5 6
intjj6 9
	teacherIdjj: C
,jjC D
TeacherApiModeljjD S
teacherApiModeljjT c
)jjc d
{kk 	
ifll 
(ll 
_contextll 
.ll 
Teachersll  
==ll! #
nullll$ (
)ll( )
{mm 
returnnn 
	NoContentnn  
(nn  !
)nn! "
;nn" #
}oo 
varpp 
teacherpp 
=pp 
awaitpp 
_contextpp  (
.pp( )
Teacherspp) 1
.pp1 2
	FindAsyncpp2 ;
(pp; <
	teacherIdpp< E
)ppE F
;ppF G
ifqq 
(qq 
teacherqq 
==qq 
nullqq 
)qq 
{rr 
returnss 
NotFoundss 
(ss  
)ss  !
;ss! "
}tt 
teacheruu 
.uu 
Nameuu 
=uu 
teacherApiModeluu *
.uu* +
Nameuu+ /
;uu/ 0
_contextvv 
.vv 
Teachersvv 
.vv 
Updatevv $
(vv$ %
teachervv% ,
)vv, -
;vv- .
awaitww 
_contextww 
.ww 
SaveChangesAsyncww +
(ww+ ,
)ww, -
;ww- .
returnxx 
Okxx 
(xx 
)xx 
;xx 
}yy 	
}zz 
}{{ ·
°E:\KelltonTech\.NET training kellton\Real Training Started\AllAssignmentsAfterGaneshLeft\Web-Api\CONNECT API TO DB\API\MappingConfigurations\AutoMapperProfile.cs
	namespace 	
API
 
. !
MappingConfigurations #
{ 
public 

class 
AutoMapperProfile "
:# $
Profile% ,
{ 
public		 
AutoMapperProfile		  
(		  !
)		! "
{

 	
	CreateMap 
< 
Teacher 
, 
TeacherApiModel .
>. /
(/ 0
)0 1
.1 2

ReverseMap2 <
(< =
)= >
;> ?
	CreateMap 
< 
	ClassRoom 
,  
ClassRoomApiModel! 2
>2 3
(3 4
)4 5
.5 6

ReverseMap6 @
(@ A
)A B
;B C
} 	
} 
} ®
ÅE:\KelltonTech\.NET training kellton\Real Training Started\AllAssignmentsAfterGaneshLeft\Web-Api\CONNECT API TO DB\API\Program.cs
var 
builder 
= 
WebApplication 
. 
CreateBuilder *
(* +
args+ /
)/ 0
;0 1
builder 
. 
Services 
. 
AddDbContext 
< 
ApiDbContext *
>* +
(+ ,
options, 3
=>4 6
options		 
.		 
UseSqlServer		 
(		 
builder		  
.		  !
Configuration		! .
.		. /
GetConnectionString		/ B
(		B C
$str		C W
)		W X
??		Y [
throw

 	
new


 %
InvalidOperationException

 '
(

' (
$str

( [
)

[ \
)

\ ]
)

] ^
;

^ _
builder 
. 
Services 
. 
AddAutoMapper 
( 
typeof %
(% &
Program& -
)- .
). /
;/ 0
builder 
. 
Services 
. 
AddControllers 
(  
)  !
. 
AddJsonOptions 
( 
options 
=> 
options &
.& '!
JsonSerializerOptions' <
.< =
ReferenceHandler= M
=N O
ReferenceHandlerP `
.` a
IgnoreCyclesa m
)m n
;n o
builder 
. 
Services 
. 
AddControllers 
(  
)  !
;! "
builder 
. 
Services 
. 
AddSwaggerGen 
( 
)  
;  !
var 
app 
= 	
builder
 
. 
Build 
( 
) 
; 
app 
. 
UseHttpsRedirection 
( 
) 
; 
app 
. 
UseAuthorization 
( 
) 
; 
app 
. 
MapControllers 
( 
) 
; 
if 
( 
app 
. 
Environment 
. 
IsDevelopment !
(! "
)" #
)# $
{ 
app   
.   

UseSwagger   
(   
)   
;   
app!! 
.!! 
UseSwaggerUI!! 
(!! 
)!! 
;!! 
}"" 
app$$ 
.$$ 
Run$$ 
($$ 
)$$ 	
;$$	 
