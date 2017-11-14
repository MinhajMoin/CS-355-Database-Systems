--Question 1
select sales.ord_num as 'Order Number', stores.stor_name as 'Store Name',titles.title as 'Title',authors.au_fname+' '+authors.au_lname as 'Author Name'
,publishers.pub_name as 'Publisher',titles.price as 'Price',sales.qty as 'Quantity', titles.price*sales.qty as 'Total Price' 
from sales,titles,authors,stores,publishers,titleauthor
where sales.ord_num like 'X999' and sales.title_id = titles.title_id and sales.stor_id=stores.stor_id and titles.pub_id= publishers.pub_id and titleauthor.au_id= authors.au_id and titles.title_id = titleauthor.title_id

--Question 2
select titles.title as 'Title',titles.pubdate as 'Publication Date',publishers.pub_name as 'Publisher Name', count(authors.au_id) as 'No. of Authors'
from titles,publishers,authors,titleauthor
where titles.title_id = titleauthor.title_id and authors.au_id = titleauthor.au_id and titles.pub_id = publishers.pub_id
group by titles.title,pub_name,pubdate

--Question 3
select title as Title,datepart(month,titles.pubdate) as 'Publishing Month',datepart(year,titles.pubdate) as 'Publishing Year',titles.type as 'Type',count(authors.au_id) as 'No. of Authors'
from authors,titles,titleauthor
where titleauthor.au_id = authors.au_id and titleauthor.title_id=titles.title_id and titles.type like 'business'
group by titles.pubdate, titles.type ,titles.title


--Question 4
select A1.au_fname+' '+A1.au_lname as 'Author 1',A2.au_fname+' '+A2.au_lname as 'Author 2',count(titles.title_id) as 'No. of Publications'
from authors A1,authors A2,titleauthor T1,titleauthor T2,titles
where titles.title_id = T1.title_id  and titles.title_id = T2.title_id and A1.au_id = T1.au_id and A2.au_id = T2.au_id and A1.au_id!=A2.au_id
group by A1.au_fname,A2.au_fname,A1.au_lname,A2.au_lname

--Question 5
select A1.au_fname+' '+A1.au_lname as 'Author 1',A2.au_fname+' '+A2.au_lname as 'Author 2',count(titles.title_id) as 'No. of Publications'
from authors A1,authors A2,titleauthor T1,titleauthor T2,titles
where titles.title_id = T1.title_id  and titles.title_id = T2.title_id and A1.au_id = T1.au_id and A2.au_id = T2.au_id and A1.au_id!=A2.au_id
group by A1.au_fname,A2.au_fname,A1.au_lname,A2.au_lname
having count(titles.title_id)>1

--Question 6
select titles.title as 'Title',publishers.pub_name as 'Publisher',employee.fname+' '+employee.lname as 'Editor'
from titles,publishers,employee,jobs
where titles.pub_id = publishers.pub_id and employee.job_id = jobs.job_id and jobs.job_desc like 'Editor' and titles.type like 'Business'

--Question 7
select authors.au_fname+' '+authors.au_lname as 'Author Name'
from authors,titleauthor,titles
where authors.au_id = titleauthor.au_id and titles.title_id = titleauthor.title_id
group by authors.au_fname,authors.au_lname
having count(titleauthor.au_id)=1

--Question 8
select stores.stor_name as 'Store Name'
from stores, sales, publishers, titles 
where publishers.pub_id = titles.pub_id and titles.title_id = sales.title_id and stores.stor_id = sales.stor_id and stores.stor_id in
(select stores.stor_id from stores,titles,sales,publishers where titles.title_id = sales.title_id and sales.stor_id=stores.stor_id and titles.pub_id = publishers.pub_id and publishers.pub_name !='New Moon Books')
group by stor_name

--Question 9
select top 1 titles.title as 'Title',sales.qty as 'Quantity Sold'
from titles,sales where sales.title_id = titles.title_id
order by sales.qty desc

--Question 10
select titles.title as 'Title',stores.stor_name as 'Store Name',sales.qty as 'Quantity' from titles,stores,sales
where stores.stor_id = sales.stor_id and titles.title_id = sales.title_id

--Question 11
select titles.title as 'Title', sum(sales.qty) as 'Total Sales'
from titles, sales, stores
where stores.stor_id = sales.stor_id and sales.title_id = titles.title_id
group by titles.title

--Question 12
select top 1 titles.title as 'Book Title',titles.ytd_sales as 'Year to Date Sales'
from titles
group by titles.title,titles.ytd_sales 
having max(titles.ytd_sales)=titles.ytd_sales
order by titles.ytd_sales desc

--Question 13
select authors.au_fname+' '+authors.au_lname as 'Author'
from titles, titleauthor,authors
where authors.au_id = titleauthor.au_id and titleauthor.title_id = titles.title_id and Datepart(year,titles.pubdate)!=1992
group by authors.au_fname,authors.au_lname

--Question 14
select authors.au_fname+' '+authors.au_lname as 'Author'
from titles,titleauthor,authors 
where authors.au_id = titleauthor.au_id and titleauthor.title_id = titles.title_id and authors.au_id in 
(select authors.au_id from titles, titleauthor, authors where authors.au_id = titleauthor.au_id and titleauthor.title_id = titles.title_id and Datepart(year,titles.pubdate)!=1992)
and Datepart(year,titles.pubdate) = 1991
group by authors.au_fname,authors.au_lname