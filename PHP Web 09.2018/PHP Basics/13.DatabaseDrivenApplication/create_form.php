<form method="post">
    <table class='table table-hover table-responsive table-bordered'>
        <tr>
            <td>Name</td>
            <td><input type="text" name="name" class='form-control' required="required"></td>
        </tr>
        <tr>
            <td>Price</td>
            <td><input type="text" name="price" class='form-control' required="required"></td>
        </tr>
        <tr>
            <td>Description</td>
            <td><textarea name="description" cols="30" rows="10" class='form-control' required="required"></textarea></td>
        </tr>
        <tr>
            <td>Category</td>
            <td><select name="category" class='form-control'>
                    <option></option>
                    <?php foreach($category_obj->getAll() as $category): ?>
                        <option value="<?=$category['id']?>"><?=$category['name']?></option>
                    <?php endforeach; ?>
                </select></td>
        </tr>
        <tr>
            <td>
                <a href='index.php' class='btn btn-default pull-left'>Read Products</a>
            </td>
            <td>
                <input type="submit" value="Create" class="btn btn-primary">
            </td>
        </tr>
    </table>
</form>