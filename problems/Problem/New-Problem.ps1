$n = (gci | Where-Object {$_.PSIsContainer}).Count + 1
$name = "{0:0000}" -f $n
mkdir $name
(Get-Content -Path "Problem.txt") -replace "public class Problem", "public class Problem$name" -replace "Euler_", "Euler_$name" | Add-Content -Path "$name\Problem$name.cs"
