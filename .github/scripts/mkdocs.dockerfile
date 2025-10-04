FROM squidfunk/mkdocs-material

RUN pip install mkdocs-macros-plugin
RUN pip install mkdocs-glightbox
RUN pip install mkdocs-include-dir-to-nav
RUN pip install markdown-callouts
RUN pip install mkdocs-git-revision-date-localized-plugin
RUN pip install mkdocs-git-committers-plugin-2
RUN pip install pillow cairosvg mike

EXPOSE 8000
