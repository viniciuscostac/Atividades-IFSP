<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
	<title>Sistema de gerenciamento de livros</title>
	
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>
<body>
	<nav class="navbar navbar-expand-lg navbar-light bg-light">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Gerenciamento de Livros</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0" style="float:right !important;">
        <li class="nav-item">
          <button class="btn btn-success" style="margin-right:25px;"><a style="text-decoration:none; color:white;" href="new">Adicionar Livro</a></button>
        </li>
        <li class="nav-item">
          <button class="btn btn-warning"><a style="text-decoration:none; color:white;"  href="list">Listar Todos Livros</a></button>
        </li>
    </div>
  </div>
</nav>
    <div align="center" class="container" style="margin-top:100px;">
        <table border="1" cellpadding="5" class="table">
            <tr class="table-dark">
                <th>ID</th>
                <th>Título</th>
                <th>Autor</th>
                <th>Valor</th>
                <th></th>
            </tr>
            <c:forEach var="book" items="${listBook}">
                <tr>
                    <td><c:out value="${book.id}" /></td>
                    <td><c:out value="${book.title}" /></td>
                    <td><c:out value="${book.author}" /></td>
                    <td><c:out value="${book.price}" /></td>
                    <td>
                    	<a href="edit?id=<c:out value='${book.id}' />">Alterar</a>
                    	&nbsp;&nbsp;&nbsp;&nbsp;
                    	<a href="delete?id=<c:out value='${book.id}' />">Remover</a>                    	
                    </td>
                </tr>
            </c:forEach>
        </table>
    </div>	
</body>
</html>
