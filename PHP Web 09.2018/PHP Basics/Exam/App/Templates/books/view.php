<?php /** @var \App\DTO\BookDTO $data */ ?>

<h1>VIEW BOOK</h1>
<p><a href="profile.php">My Profile</a></p>
<p><strong>Book Title: </strong><?=$data->getTitle()?></p>
<p><strong>Book Author: </strong><?=$data->getAuthor()?></p>
<p><strong>Description: </strong><?=$data->getDescription()?></p>
<p><strong>Genre: </strong><?=$data->getGenre()->getName()?></p>
<div><img src="<?=$data->getImage()?>" width="250px" height="350px"></div>
