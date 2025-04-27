var 
  x,f,f1,f2,a,b,h,sigma,sigma2: real;
  i,j,n: integer;
begin
  a := 0.3;
  b := 0.9;
  n := 10;
  h := (b - a) / n;
  for i := 0 to n - 1 do begin
    x := a + i*h;
    f := sin(sqr(x) + 0.6)/(1.5 + cos(0.8 * x + 1.2));
    sigma += h * f;
  end;
  for i := 1 to n-1 do begin
    x := a + i*h;
    f := sin(sqr(x) + 0.6)/(1.5 + cos(0.8 * x + 1.2));
    writeln('x',i,' = ', x, '   ', 'f(x',i,') = ', f);
    sigma2 += f;
  end;
  x := a + 0 * h;
  f1 := sin(sqr(x) + 0.6)/(1.5 + cos(0.8 * x + 1.2));
  x := a + 10 * h;
  f2 := sin(sqr(x) + 0.6)/(1.5 + cos(0.8 * x + 1.2)); 
  sigma2 += (f1 + f2) / 2;
  writeln('метод средних прямоугольников: ',sigma:0:3);
  writeln('метод трапеций: ',sigma2 * h:0:3);
end.