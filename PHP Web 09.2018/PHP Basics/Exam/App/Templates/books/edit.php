<?php /** @var \App\DTO\BookFormDTO $data*/?>

<h1>EDIT BOOK</h1>
<?php foreach ($errors as $error): ?>
    <p style="color: red"><?=$error?></p>
<?php endforeach;?>
<p><a href="profile.php">My Profile</a></p>
<form method="post">
    <div>
        <label for="title">Book Title:</label>
        <input type="text" name="title" value="<?=$data != null ? $data->getBook()->getTitle() : ""?>">
    </div>
    <div>
        <label for="author">Book Author:</label>
        <input type="text" name="author" value="<?=$data != null ? $data->getBook()->getAuthor() : ""?>">
    </div>
    <div>
        <label for="description">Description:</label>
        <textarea name="description"><?=$data != null ? $data->getBook()->getDescription() : ""?></textarea>
    </div>
    <div>
        <label for="image">Image URL:</label>
        <input type="text" name="image" value="<?=$data != null ? $data->getBook()->getImage() : ""?>">
    </div>
    <div>
        <label for="genre_id">Genre:</label>
        <select name="genre_id">
            <?php foreach ($data->getGenres() as $genre): ?>
                <?php if ($data->getBook()->getGenre()->getName() == $genre->getName()):?>
                    <option selected="selected" value="<?=$genre->getGenreId()?>"><?=$genre->getName()?></option>
                <?php else: ?>
                    <option value="<?=$genre->getGenreId()?>"><?=$genre->getName()?></option>
                <?php endif;?>
            <?php endforeach; ?>
        </select>
    </div>
    <div>
        <img src="<?=$data != null ? $data->getBook()->getImage() : ""?>" width="250px" height="350px">
    </div>
    <div>
        <input type="submit" name="edit" value="Edit">
    </div>
</form>