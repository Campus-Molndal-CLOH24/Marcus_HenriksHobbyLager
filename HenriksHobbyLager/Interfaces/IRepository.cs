﻿using System;
using System.Collections.Generic;

namespace RefactoringExercise.Interfaces;

internal interface IRepository<T>
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
    IEnumerable<T> Search(Func<T, bool> predicate);
}