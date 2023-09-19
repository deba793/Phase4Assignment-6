﻿using System;
using System.Collections.Generic;

namespace Phase4Assignment_6.Models;

public partial class Author
{
    public int AuthorId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
