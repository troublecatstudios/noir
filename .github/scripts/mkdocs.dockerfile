FROM squidfunk/mkdocs-material

RUN pip install mkdocs-macros-plugin
RUN pip install mkdocs-glightbox
RUN pip install mkdocs-include-dir-to-nav

WORKDIR /tmp/source

COPY mkdocs.yml     ./mkdocs.yml
COPY ./docs         /tmp/source/docs

RUN mkdocs -v build

EXPOSE 8000
