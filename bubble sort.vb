Module bubblesort
sub main ()
Dim arr () as integer  = {5,1,4,2,8}
Dim outer,inner,temp as integer
Dim n as integer = arr.Length

for outer = n-1 to 1 step -1
    for inner = 0 to outer-1
        if arr(inner)>arr(inner+1) then
            temp=arr(inner)
            arr(inner) = arr(inner+1)
            arr(inner+1)=temp

        End if

    Next

Next
dim i as integer
for i=0 to n-1
Console.Write(arr(i)&" ")

Next
Console.Read()
End sub
End Module