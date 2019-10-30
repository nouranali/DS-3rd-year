Module selectionsort
sub main ()
Dim arr () as integer  = {5,1,4,2,8}
Dim outer,inner,min_idx,temp as integer
Dim n as integer = arr.Length
min_idx=0
for outer = 0 to n-1 
min_idx=outer 
    for inner = outer+1 to n-1
        if arr(inner)<arr(min_idx) then
            min_idx=inner

        End if
        
    Next
    temp=arr(outer)
    arr(outer)= arr(min_idx)
    arr(min_idx)=temp
Next
dim i as integer
for i=0 to n-1
Console.Write(arr(i)&" ")

Next
Console.Read()
End sub
End Module